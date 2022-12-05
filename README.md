# �������� �������

### ������ �1
�������� �� C# ���������� ��� �������� ������� ��������, ������� ����� ��������� ������� ����� �� ������� � ������������ �� ���� ��������. </br>
������������� � ����������������� ������:
* ����-�����
* �������� ���������� ������ �����
* ���������� ������� ������ ��� ������ ���� ������ � compile-time
* �������� �� ��, �������� �� ����������� �������������

### ������ �2
� ���� ������ 'MS SQL Server' ���� �������� � ���������.</br>
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������.</br> 
�������� SQL ������ ��� ������ ���� ��� '���� �������� � ��� ���������'.</br>
���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.</br>
</br>
��������� ������ ��������� � ����� ''Question_2.sql''
'''
select Products.Name as product_name, ResultTable.category_name as category_name
from Products
    left join 
        (select CategoriesOfProducts.ProductId as product_id, Categories.Name as category_name
        from CategoriesOfProducts
            join Categories on CategoriesOfProducts.CategoryId = Categories.Id) as ResultTable
    on (ResultTable.product_id = Products.Id)
'''


