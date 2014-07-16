SELECT u.name AS 'Пользователи', g.completename AS 'Группы'
FROM glpi_users u
	INNER JOIN glpi_groups_users gu ON(u.id=gu.users_id)
	INNER JOIN glpi_groups g ON(gu.groups_id=g.id)