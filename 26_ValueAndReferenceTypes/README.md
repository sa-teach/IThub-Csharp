### Тема LXP: "КТ №26 Ограничения ссылочного типа и типа значения"

#### Задание 1. Обёртки

1. ReferenceBox<T> where T : class с методами Set(T item), bool IsEmpty, T? Get(), использующий null как «пустое» состояние.
2. ValueBox<T> where T : struct с тем же набором методов, использующий Nullable<T> (T?) как «пустое» состояние.
3. Продемонстрируйте ReferenceBox<string> (или своим классом): пустое и заполненное состояние.
4. Продемонстрируйте ValueBox<int> (или своей структурой): пустое и заполненное состояние.
5. Продемонстрируйте (закомментированным кодом с пояснением), что ReferenceBox<int> и ValueBox<string> не компилируются.

| Действие | Ожидаемый результат |
| :--- | :--- |
| новый `ReferenceBox<string>` | `IsEmpty == true` |
| после `Set("Алина")` | `IsEmpty == false`, `Get() == "Алина"` |
| новый `ValueBox<int>` | `IsEmpty == true` |
| после `Set(25)` | `IsEmpty == false`, `Get() == 25` |

<img width="847" height="933" alt="Снимок экрана 2026-10-22 в 13 36 42" src="https://github.com/user-attachments/assets/6321fc2b-1693-4b1b-8ebb-0e7326ceb7c7" />
<img width="894" height="971" alt="Снимок экрана 2026-10-22 в 13 37 18" src="https://github.com/user-attachments/assets/6f19f82d-a9d8-48c2-8967-e3aad22bf22f" />
<img width="1370" height="215" alt="Снимок экрана 2026-10-22 в 13 39 03" src="https://github.com/user-attachments/assets/30a22a82-25a1-407d-84af-b71bfe89bbc7" />


#### Вариант 2. Кэш

1. ReferenceCache<T> where T : class с методом bool TryGet(out T? value), возвращающим false и null, если кэш пуст, и true с сохранённым значением — иначе.
2. ValueCache<T> where T : struct с тем же по смыслу методом bool TryGet(out T? value), использующим Nullable<T> внутри для представления «пусто».
3. Продемонстрируйте ReferenceCache<string> (или своим классом): попадание и промах кэша.
4. Продемонстрируйте ValueCache<double> (или своей структурой): попадание и промах кэша.
5. Продемонстрируйте (закомментированным кодом с пояснением), что ReferenceCache<double> и ValueCache<string> не компилируются.


| Действие | Ожидаемый результат |
| :--- | :--- |
| `TryGet` на пустом `ReferenceCache<string>` | `false`, значение `null` |
| `TryGet` на заполненном `ReferenceCache<string>` | `true`, корректное значение |
| `TryGet` на пустом `ValueCache<double>` | `false` |
| `TryGet` на заполненном `ValueCache<double>` | `true`, корректное значение |

<img width="718" height="757" alt="Снимок экрана 2026-10-22 в 12 51 07" src="https://github.com/user-attachments/assets/b7505cfa-7ab9-4bf4-951d-7c295ff669bc" />
<img width="676" height="726" alt="Снимок экрана 2026-10-22 в 12 50 27" src="https://github.com/user-attachments/assets/b450d52e-03da-4242-92c2-b425c292ee8b" />
<img width="1395" height="190" alt="Снимок экрана 2026-10-22 в 13 40 54" src="https://github.com/user-attachments/assets/9ab16616-9f30-4ca1-b328-d3bcf9a12b99" />

