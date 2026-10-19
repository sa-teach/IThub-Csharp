### Тема LXP: «Контрольная точка №24 — ограниченные классы»
#### Вариант 2. Инвентарь предметов
1. Абстрактный базовый класс Item со свойством string Name { get; init; }, decimal Value { get; init; } и абстрактным методом string GetDescription().
2. Обобщённый класс Inventory<T> where T : Item с методами Add(T item), decimal GetTotalValue() (сумма Value всех предметов) и void PrintAll() (выводит результат GetDescription() для каждого).
3. Производные классы Weapon : Item (переопределяет GetDescription(), добавляя урон) и Potion : Item (переопределяет GetDescription(), добавляя эффект).
4. Создайте Inventory<Weapon> и Inventory<Potion>, добавьте в каждый минимум два предмета.
5. Продемонстрируйте GetTotalValue() и PrintAll() для обоих инвентарей.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `Inventory<Weapon>.GetTotalValue()` | сумма Value всех добавленных предметов |
| `Inventory<Weapon>.PrintAll()` | описание каждого предмета, специфичное для Weapon |
| `Inventory<Potion>` с собственным набором данных | работает независимо от `Inventory<Weapon>` |

<img width="581" height="1005" alt="Снимок экрана 2026-10-19 в 21 02 44" src="https://github.com/user-attachments/assets/a78006ea-52ae-4006-a608-db41dc2caf46" />
<img width="588" height="1041" alt="Снимок экрана 2026-10-19 в 21 04 50" src="https://github.com/user-attachments/assets/286a93ea-0842-405a-bf47-f3a2b0a2735d" />
