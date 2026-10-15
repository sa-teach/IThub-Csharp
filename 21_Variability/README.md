### Тема LXP: "Контрольная точка №21 — ковариантность и контравариантность делегатов"
#### Вариант 2. Игровые персонажи

1. Классы Character и Wizard : Character.
2. delegate TCharacter CharacterProducer\<out TCharacter\>(); — ковариантный делегат.
3. Метод, возвращающий Wizard, присвойте переменной типа CharacterProducer<Character> и вызовите его.
4. delegate void CharacterConsumer\<in TCharacter\>(TCharacter character); — контравариантный делегат.
5. Метод, принимающий Character, присвойте переменной типа CharacterConsumer<Wizard> и вызовите его с экземпляром Wizard. Дополнительно продемонстрируйте, что то же самое работает «бесплатно» через встроенные Func\<out TResult\>/Action\<in T\>, без собственных делегатов.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `CharacterProducer<Character> p = SpawnWizard;` (метод возвращает `Wizard`) | компилируется, `p()` возвращает объект `Wizard` как `Character` |
| `CharacterConsumer<Wizard> c = DamageCharacter;` (метод принимает `Character`) | компилируется, `c(new Wizard())` вызывает `DamageCharacter` |
| `Func<Character> f (у меня spawnCharacterFunc) = SpawnWizard;` без собственного делегата | компилируется аналогично, без `out`/`in`, объявленных вручную |

<img width="1824" height="854" alt="Снимок экрана 2026-10-15 в 20 07 59" src="https://github.com/user-attachments/assets/4471a382-9b4b-4dec-aa8c-0e7339428e3f" />

<img width="1639" height="940" alt="Снимок экрана 2026-10-15 в 20 08 36" src="https://github.com/user-attachments/assets/a1ed6fd9-e623-4019-95e3-e37e4f054fbe" />
