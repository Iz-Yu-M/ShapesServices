# Тестовое задание

### Вопрос №1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. </br>
Дополнительно к работоспособности оценим:
* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным

### Вопрос №2
В базе данных 'MS SQL Server' есть продукты и категории.</br>
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.</br> 
Напишите SQL запрос для выбора всех пар '«Имя продукта – Имя категории»'.</br>
Если у продукта нет категорий, то его имя все равно должно выводиться.</br>
</br>
Требуемый запрос находится в файле ''Question_2.sql''
'''
select Products.Name as product_name, ResultTable.category_name as category_name
from Products
    left join 
        (select CategoriesOfProducts.ProductId as product_id, Categories.Name as category_name
        from CategoriesOfProducts
            join Categories on CategoriesOfProducts.CategoryId = Categories.Id) as ResultTable
    on (ResultTable.product_id = Products.Id)
'''


