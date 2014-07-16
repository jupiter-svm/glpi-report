SELECT DISTINCT(comp.name) AS `Название компьютера`, comp.contact AS `Учётная запись`, 
	   gp.specificity AS 'Частота'
FROM glpi_computers comp
   INNER JOIN glpi_computers_deviceprocessors gp ON(gp.computers_id=comp.id)
WHERE gp.specificity >= '1700' AND
      gp.specificity <= '1800'