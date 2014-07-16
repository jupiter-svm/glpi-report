SELECT gtk.name AS `Имя пользователя`, 
	   COUNT(u.`name`) AS `Количество`, gtk.date AS `Дата`
FROM glpi_tickets gtk
    INNER JOIN `glpi_tickets_users` gtu ON(gtu.`tickets_id`=gtk.`id`)
	INNER JOIN glpi_users u ON(u.`id`=gtu.`users_id`)
WHERE gtu.`type`='2' 
GROUP BY gtk.id
HAVING COUNT(u.`name`)>1
ORDER BY gtk.date DESC