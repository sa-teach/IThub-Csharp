### Тема LXP: "КТ №29 Обобщённые интерфейсы"
#### Вариант 2. Репозиторий с ограничением

1. interface IEntity { int Id { get; } }.
2. interface IRepository<T> where T : IEntity { void Add(T item); T? GetById(int id); }.
3. Классы Product : IEntity и Customer : IEntity, каждый с собственными дополнительными свойствами.
4. class InMemoryRepository<T> : IRepository<T> where T : IEntity, хранящий элементы во внутреннем списке.
5. Создайте InMemoryRepository<Product> и InMemoryRepository<Customer>, добавьте элементы и продемонстрируйте GetById для обоих, включая случай отсутствующего Id.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `InMemoryRepository<Product>.GetById(существующий Id)` | соответствующий `Product` |
| `InMemoryRepository<Product>.GetById(несуществующий Id)` | `null` |
| `InMemoryRepository<Customer>` с собственным набором данных | работает независимо от репозитория `Product` |

<img width="642" height="1196" alt="Снимок экрана 2026-10-27 в 20 34 15" src="https://github.com/user-attachments/assets/caada99f-4c82-4d6d-8a12-943c9f5ef723" />
<img width="694" height="1224" alt="Снимок экрана 2026-10-27 в 20 39 06" src="https://github.com/user-attachments/assets/cad457bd-a9c2-4c71-a834-104ed5c21a5d" />

