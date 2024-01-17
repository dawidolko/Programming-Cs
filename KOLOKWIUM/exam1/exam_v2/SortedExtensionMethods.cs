using System;

namespace test
{
    public static class SortedExtensionMethods
    {
        public static IEnumerable<T> MergeAndSort<T>(this IEnumerable<T> first, IEnumerable<T> second) where T : IHuman
        {
            return first.Concat(second).OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
        }

        public static IEnumerable<Student> SortStudents(this IEnumerable<Student> students)
        {
            return students.OrderBy(student => student.Grade);
        }

        public static IEnumerable<Worker> SortWorkers(this IEnumerable<Worker> workers)
        {
            return workers.OrderBy(worker => worker.MoneyPerHour());
        }
    }
}

