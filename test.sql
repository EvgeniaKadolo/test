--
-- Структура таблицы categories
--

CREATE TABLE categories (
  id int NOT NULL,
  name varchar(255) NOT NULL
)

--
-- Дамп данных таблицы `categories`
--

INSERT INTO categories (id, name) VALUES
(1, 'category1'),
(2, 'category2'),
(3, 'category3'),
(4, 'category4');

--
-- Структура таблицы category_product
--

CREATE TABLE category_product (
  id int NOT NULL,
  product_id int NOT NULL,
  category_id int NOT NULL
)

--
-- Дамп данных таблицы category_product
--

INSERT INTO category_product (id, product_id, category_id) VALUES
(1, 3, 3),
(2, 3, 4),
(3, 1, 2),
(4, 2, 3);

--
-- Структура таблицы products
--

CREATE TABLE products (
  id int NOT NULL,
  name varchar(255) NOT NULL
)

--
-- Дамп данных таблицы products
--

INSERT INTO products (id, name) VALUES
(1, 'product1'),
(2, 'product2'),
(3, 'product3'),
(4, 'product4');

--
-- Индексы таблицы categories
--
ALTER TABLE categories
  ADD PRIMARY KEY (id);

--
-- Индексы таблицы category_product
--
ALTER TABLE category_product
  ADD PRIMARY KEY (id),
  ADD KEY product_id (product_id),
  ADD KEY category_id (category_id);

--
-- Индексы таблицы products
--
ALTER TABLE products
  ADD PRIMARY KEY (id);

--
-- AUTO_INCREMENT для таблицы categories
--
ALTER TABLE categories
  MODIFY id int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы category_product
--
ALTER TABLE category_product
  MODIFY id int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы products
--
ALTER TABLE products
  MODIFY id int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа таблицы category_product
--
ALTER TABLE category_product
  ADD CONSTRAINT category_product_ibfk_1 FOREIGN KEY (category_id) REFERENCES `categories` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT category_product_ibfk_2 FOREIGN KEY (product_id) REFERENCES `products` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;


--
-- Запрос для выбора всех пар «Имя продукта – Имя категории»
--
SELECT products.name , categories.name
  FROM category_product
JOIN categories
  ON categories.id = category_product.category_id
RIGHT JOIN products
  ON products.id = category_product.product_id;
