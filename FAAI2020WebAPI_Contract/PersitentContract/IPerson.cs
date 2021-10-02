namespace FAAI2020WebAPI_Contract.PersitentContract
{
    using System;
    public interface IPerson : IPersistentBase
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        DateTime DayOfBirth { get; set; }
    }
}
