static List<List<int>> GroupsNumbers(uint number)
        {
            /// Создание листа для списка групп
            List<List<int>> groups = new List<List<int>>();
 
            /// Если переданное число ноль, то возвращается пустой список групп
            if (number == 0)
                return groups;
 
            /// Запись группы с одни элеменом - единицей. Такая группа всегда есть в списке групп
            groups.Add(new List<int>() { 1 });
 
            /// Если переданное число единица, то возвращается список групп с одной группой - единицей
            if (number == 1)
                return groups;
 
            /// Создание листа чисел содержащего все числа от 2 до заднного
            List<int> numbers = Enumerable.Range(2, (int)number - 1).ToList();
 
            /// Цикл пока в листе есть хоть один элемент
            while (numbers.Any()) /// Проверка есть ли в литсе любой элемент
            {
                /// Создание новой группы как копии листа с оставшимися числами
                List<int> group = numbers.ToList();
 
                /// Перебор элементов группы. i - индекс проверяемого элемента
                for (int i = 0; i < group.Count; i++)
                    /// Удаление из группы всех элементов кратных проверяемому, кроме его самого
                    group.RemoveAll(num => num != group[i] && num % group[i] == 0);
 
                /// Добавление группы в список групп
                groups.Add(group);
 
                /// Удаление из листа чисел всех чисел оставшихся в добавленной группе
                numbers.RemoveAll(num => group.Contains(num));
            }
        /// Возврат списка групп
            return groups;
        }