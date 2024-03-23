SELECT products.name + (CASE WHEN categories.name IS NULL THEN '' ELSE ' - ' + categories.name END) AS product_category
FROM products LEFT JOIN
	products_categories ON products.id = products_categories.product_id LEFT JOIN
		categories ON categories.id = products_categories.category_id
ORDER BY products.name ASC, categories.name ASC