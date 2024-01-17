using System;
namespace test
{
    public interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void Print();
    }
}

