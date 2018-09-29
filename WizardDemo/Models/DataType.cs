namespace WizardDemo.Models
{
    public enum DataType
    {
        System_Boolean = 1,
        System_Int32 = 2,
        System_Int64 = 4,
        System_Double = 8,
        System_DateTime = 16,
        System_String = 32,

        LongOrDouble = (System_Int64 | System_Double),
        Numeric = (System_Int32 | System_Int64 | System_Double),
        ANY = (System_Boolean | System_Int32 | System_Int64 | System_Double | System_DateTime | System_String)
    }
}
