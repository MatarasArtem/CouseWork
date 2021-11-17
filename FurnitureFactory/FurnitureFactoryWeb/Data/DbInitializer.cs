using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize(FurnitureFactoryContext db)
        {
            db.Database.EnsureCreated();

            // Проверка занесены ли данные в таблицу Customers
            if (db.Customers.Any())
            {
                return;   // База данных уже инициализирована
            }

            int customer_number = 20;
            int employee_number = 20;
            int material_number = 7;
            int order_number = 10;
            int supplyMaterial_number = 10;
            int orderRecord_number = 10;
            int position_nember = 10;
            int furniture_number = 10;
            int provider_number = 5;
            Random random = new Random(1);

            // Заполнение таблицы должностей
            string[] str_positionName = { "Дизайнер", "Конструктор", "Столяр", "Маляр", "Комплектовщик", "Сборщик мебели", "Консультант", "Менеджер", "Администратор", "Складовщик" };
            int count_positionName = str_positionName.GetLength(0);
            for (int positionId = 1; positionId <= position_nember; positionId++)
            {
                string positionName = str_positionName[random.Next(count_positionName)];
                db.Positions.Add(new Position { Name = positionName });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            // Заполнение таблицы сотрудников
            string[] str_surname = { "Иванов", "Петров", "Сидоров", "Расшивалов", "Говрылов", "Крышнев", "Ермашкевич", "Бондарец", "Зайцев", "Соболев" };
            string[] str_name = { "Виктор", "Владимир", "Вадим", "Анатолий", "Михаил", "Александр", "Артем", "Алексей", "Сергей", "Дмитрий" };
            string[] str_middlename = { "Иванович", "Петрович", "Владимирович", "Михайлович", "Дмитриевич", "Викторович", "Александрович", "Анатольевич", "Сергеевич", "Владисловович" };
            string[] str_education = { "Высшее", "Среднее", "Дополнительное" };
            int count_surname = str_surname.GetLength(0);
            int count_name = str_name.GetLength(0);
            int count_middlename = str_middlename.GetLength(0);
            int count_education = str_education.GetLength(0);
            for (int employeeId = 1; employeeId <= employee_number; employeeId++)
            {
                string surname = str_surname[random.Next(count_surname)];
                string name = str_name[random.Next(count_name)];
                string middlename = str_middlename[random.Next(count_middlename)];
                string education = str_education[random.Next(count_education)];
                int positionId = random.Next(1, position_nember - 1);
                db.Employees.Add(new Employee {Surname = surname, Name = name, MiddleName = middlename, Education = education, PositionId = positionId});
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            //Заполнение таблицы клиентов
            string[] str_address = { "проспект Речицкий д.6", "Гагарина д.12", "Колоса д.65", "Совецкая д.23", "Кирова д.85" };
            string[] str_phone = { "+375447348721", "+375293745291", "+375338549125", "+375448123457", "+375294713781", "+375449257328", "+375448235842", "+375293741238", "+375448235831", "+375337458219" };
            int count_address = str_address.GetLength(0);
            int count_phone = str_phone.GetLength(0);
            for (int customerId = 1; customerId <= customer_number; customerId++)
            {
                string address = str_address[random.Next(count_address)];
                string phone = str_phone[random.Next(count_phone)];
                db.Customers.Add(new Customer {Phone = phone, Address = address });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            // Заполнение таблицы поставщиков
            string[] str_providerName = { "Евростандарт", "РосАкс", "Росла", "Кроношпан", "Мастер" };
            for (int providerId = 1; providerId <= provider_number; providerId++)
            {
                foreach (var str in str_providerName)
                {
                    db.Providers.Add(new Provider { Name = str });
                }
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            // Заполнение таблицы заказов
            for (int orderId = 1; orderId <= order_number; orderId++)
            {
                int customerId = random.Next(1, customer_number - 1);
                int employeeId = random.Next(1, employee_number - 1);
                DateTime today = DateTime.Now.Date;
                DateTime date = today.AddDays(-orderId);
                int discount = random.Next(5, 10);
                int evaluation = random.Next(5, 10);
                db.Orders.Add(new Order { CustomerId = customerId, EmployeeId = employeeId, Date = date, Discount = discount, Evaluation = evaluation });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            // Заполнение таблицы изделий
            string[] str_furnitureName = { "Шкаф", "Стул", "Стол", "Комод", "Кресло", "Полка", "Кровать", "Скамья", "Стенка", "Тахта", "Светильник", "Тумба", "Диван", "Бюро", "Гардероб" };
            string[] str_furnitureDescription = { "Стильная мебель для гостиной", "Эргономичная мебель для домашнего офиса", "Практичная мебель для прихожей", "Мебель для кухни" };
            int count_furnitureName = str_furnitureName.GetLength(0);
            int count_furnitureDescription = str_furnitureDescription.GetLength(0);
            for (int furnitureId = 1; furnitureId <= furniture_number; furnitureId++)
            {
                string name = str_furnitureName[random.Next(count_furnitureName)];
                string description = str_furnitureDescription[random.Next(count_furnitureDescription)];
                decimal price = 100 * (decimal)random.NextDouble();
                int number = random.Next(1, 10);
                db.Furnitures.Add(new Furniture {Name = name, Description = description, Price = price, Number = number });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            //Заполнение таблицы записи о заказе
            for (int orderRecordId = 1; orderRecordId <= orderRecord_number; orderRecordId++)
            {
                int orderId = random.Next(1, order_number - 1);
                int furnitureId = random.Next(1, furniture_number - 1);
                decimal totalOrderPrice = 200 * (decimal)random.NextDouble();
                int numberOrderByDate = random.Next(1, 10);
                db.OrderRecords.Add(new OrderRecord { OrderId = orderId, FurnitureId = furnitureId, TotalOrderPrice = totalOrderPrice, NumberOrderByDate = numberOrderByDate });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            //Заполнение таблицы заказаные материалы (промежуточная таблица)
            for (int supplyMaterialId = 1; supplyMaterialId <= supplyMaterial_number; supplyMaterialId++)
            {
                int furnitureId = random.Next(1, furniture_number - 1);
                int materialId = random.Next(1, material_number - 1);
                db.SupplyMaterials.Add(new SupplyMaterial { FurnitureId = furnitureId, MaterialId = materialId });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();

            // Заполнение таблицы должностей
            string[] str_materialName = { "ДСП", "", "МДФ", "меламин", "постформинг", "шпон", "массив" };
            int count_materialName = str_materialName.GetLength(0);
            for (int materialId = 1; materialId <= material_number; materialId++)
            {
                int providerId = random.Next(1, provider_number - 1);
                string name = str_materialName[random.Next(count_materialName)];
                db.Materials.Add(new Material { Name = name, ProviderId = providerId });
            }
            //Сохранение изменений в базе данных, связанную с объектом контекста
            db.SaveChanges();
        }
    }
}