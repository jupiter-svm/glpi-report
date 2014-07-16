SELECT u.name AS `Имя пользователя`, g.name AS `Название группы`
FROM glpi_users u
	INNER JOIN glpi_groups_users gu ON(gu.users_id=u.id)
	INNER JOIN glpi_groups g ON(g.id=gu.groups_id)
UNION
SELECT u1.name,''
FROM glpi_users u1
WHERE NOT EXISTS(
					SELECT*FROM glpi_groups_users gu1
					  INNER JOIN glpi_groups g1 ON(g1.id=gu1.groups_id)
					WHERE gu1.users_id=u1.id
						
				)