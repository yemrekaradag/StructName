Another type of direct access collections are strings. A string is a collection of characters that can be accessed by their index, in the same way we access the elements of an array. Strings are also implemented as class objects in C#. The String class is used for concatenating, returning substrings, adding characters, removing characters, etc. It contains a large number of methods for performing standard operations on strings, such as C# strings are immutable, meaning that once a string is initialized, it cannot be changed. When you replace a string, a copy of the string is created instead of replacing the original string.

This behavior can cause performance degradation in some cases, so the .NET Framework provides a <b>StringBuilder</b> class that lets you work with mutable strings.

<h1>Structs</h1>
A struct is a composite data type that holds data that can be made up of many different data types. For example, an employee record consists of the employee's name (a string), salary (an integer), ID number (a string or an integer), and other attributes. A powerful enhancement for C# structures is the ability to define methods that can operate on the data in a structure. This makes a struct somewhat like a class, but you cannot derive a new type from a struct.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Doğrudan erişim koleksiyonlarının başka bir türü de dizelerdir(string). Bir string bir dizinin öğelerine erişmemizle aynı şekilde, indekslerine göre erişilebilen bir karakter koleksiyonudur. Dizeler de C#'ta sınıf nesneleri olarak uygulanır. String sınıfı, birleştirme, alt dizeleri döndürme, karakter ekleme, karakterleri kaldırma vb. gibi dizeler üzerinde standart işlemler gerçekleştirmek için çok sayıda metod içerir. C# dizeleri değişmezdir, yani bir dize başlatıldığında değiştirilemez. Bir dizeyi değiştirdiğinizde, orijinal dizeyi değiştirmek yerine dizenin bir kopyası oluşturulur.

Bu davranış, bazı durumlarda performansın düşmesine neden olabilir, bu nedenle .NET Framework, değiştirilebilir dizelerle çalışmanıza olanak tanıyan bir <b>StringBuilder</b> sınıfı sağlar.

<h1>Yapılar (Structs)</h1>
Yapı (struct), birçok farklı veri türünden oluşabilen verileri tutan bileşik bir veri türüdür. Örneğin, bir çalışan kaydı, çalışanın adından (bir dize), maaştan (bir tam sayı), kimlik numarasından (bir dize veya bir tam sayı) ve diğer niteliklerden oluşur. C# yapıları için güçlü bir geliştirme, bir yapıdaki veriler üzerinde işlem yapabilecek metod tanımlama yeteneğidir. Bu, bir yapıyı bir şekilde bir sınıf gibi yapar, ancak bir yapıdan yeni bir tür türetemezsiniz.
