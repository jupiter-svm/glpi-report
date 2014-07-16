SELECT 
	CASE gtk.priority  
	   WHEN '1' THEN 'Очень низкий'  
	   WHEN '2'	THEN 'Низкий'  
	   WHEN '3' THEN 'Средний'  
	   WHEN '4' THEN 'Высокий'  
	   WHEN '5' THEN 'Очень высокий'  
	   WHEN '6' THEN 'Наивысший'  
	   ELSE ''  
	END AS 'Приоритет', 
	CASE status  
		 WHEN 'new' THEN 'Новая' 
		 WHEN 'assign' THEN 'В работе (назначена)' 
		 WHEN 'plan' THEN 'В работе (запланирована)' 
		 WHEN 'waiting' THEN 'Ожидается решение' 
		 WHEN 'solved' THEN 'Решённая' 
		 WHEN 'closed' THEN 'Закрытая' 
		 ELSE CONCAT('Статус не определён (',status,')') 
	   END AS 'Статус заявки', 
	( 
	  SELECT itcat.name  
	  FROM glpi_itilcategories itcat  
	  WHERE itcat.id=gtk.itilcategories_id 
	) AS 'Категория запроса', 
	'Новгородский' AS 'Филиал', 
	( 
	  SELECT u.comment  
	  FROM glpi_users u  
		INNER JOIN glpi_tickets_users gtu ON(gtu.users_id=u.id)  
	  WHERE gtu.tickets_id=gtk.id AND  
			gtu.type='1' 
	) AS 'Подразделение', 
   'ул. Людогоща, д. 2' AS 'Адрес', 
	DATE_FORMAT(gtk.date,'%d.%m.%Y') AS 'Дата подачи запроса', 
	DATE_FORMAT(gtk.date,'%H:%i') AS 'Время подачи запроса', 
   ( 
	 SELECT  
		DATE_FORMAT(gv1.validation_date,'%d.%m.%Y %H:%i:%s')  
	  FROM glpi.glpi_ticketvalidations gv1  
		  INNER JOIN glpi_tickets gtk1 ON(gtk1.id=gv1.tickets_id) 
	  WHERE  
		  gtk1.id=gtk.id       AND  
		  gtk1.status='closed' AND  
		  gtk1.is_deleted=0    AND  
		  gv1.validation_date= 
		  ( 
			SELECT MIN(validation_date)  
			FROM glpi.glpi_ticketvalidations gv2  
				INNER JOIN glpi_tickets gtk2 ON(gtk2.id=gv2.tickets_id) 
			WHERE  
				gtk2.id=gtk1.id       AND  
				gtk2.status='closed' AND  
				gtk2.is_deleted=0 
		  ) 
	) AS 'Передано исполнителю запроса', 
   ( 
	SELECT CONCAT(u.realname,' (',u.comment,')')  
	FROM glpi_users u  
		INNER JOIN glpi_tickets_users gtu ON(gtu.users_id=u.id)  
	WHERE gtu.tickets_id=gtk.`id` AND  
		  gtu.type='2' LIMIT 1 
   ) AS 'Кому назначено', 
   DATE_FORMAT(gtk.solvedate,'%d.%m.%Y') AS 'Дата разрешения инцидента',  
   DATE_FORMAT(gtk.solvedate,'%H:%i') AS 'Время разрешения инцидента',  
   DATE_FORMAT(gtk.closedate,'%d.%m.%Y %H:%i') AS 'Реальное время устранения',  
   DATE_FORMAT(gtk.due_date,'%d.%m.%Y %H:%i') AS 'Плановое время устранения',  
   ( 
	 SELECT SEC_TO_TIME(glsl.resolution_time)  
	  FROM glpi_slas glsl  
	  WHERE glsl.id=gtk.slas_id 
   ) 
   AS 'Плановое время SLA', 
   gtk.content AS 'Описание неисправности', 
   SUBSTRING(solution,10,LENGTH(solution)-19) AS 'Принятые меры, причина неисправности' 
   FROM glpi_tickets gtk 
   WHERE gtk.is_deleted=0 