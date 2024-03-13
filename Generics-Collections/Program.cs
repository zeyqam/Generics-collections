
using Generics_Collections;
using Generics_Collections.Controllers;
using Generics_Collections.Data;
using Microsoft.VisualBasic;
using System.Collections;

//Repository<string> data1 = new Repository<string>();

//Repository<int> data2 = new Repository<int>();

//Repository<bool> data3 = new Repository<bool>();

//Repository<Book,BaseEntity> data4 = new Repository<Book,BaseEntity>();

//Collections----None generic-- generic olmayan arraylist,hashtable sort list stack qeue
// list, ienumarable,dictionary



//ArrayList list1=new ArrayList ();
//list1.Add (100);
//list1.Add("salam");
//list1.Add((true));
//foreach (var  item in list1)
//{
//    Console.WriteLine(item);
//}
// Hashtable hashtable = new Hashtable();

////hashtable.Add("role", "admin");
////hashtable.Add("name", "Nesit");
//hashtable.Add(100,200);
//hashtable.Add(200, 200);
//foreach(DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}
//SortedList sortedList = new SortedList();
//sortedList.Add(5, 100);
//sortedList.Add(55, 200);
//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}
//SortedList<string,int> datas=new SortedList<string,int>();
//datas.Add("roleId", 100);
//datas.Add("age", 30);

//foreach (KeyValuePair<string,int> item in datas)
//{
//    Console.WriteLine(item.Key+"-"+item.Value);
//}
//Dictionary<string,string> datas= new Dictionary<string,string>();
//datas.Add("test1", "salam1");
//datas.Add("test2", "salam2");
//datas.Add("test3", "salam3");

//foreach (KeyValuePair<string,string> item in datas)
//{
//    if (item.Value == "salam1")
//    {
//        Console.WriteLine(item.Key + item.Value);
//    }
//}


//Console.WriteLine(datas["test1"]);


//Stack<int> nums = new Stack<int>();
//nums.Push(1);

//nums.Push(200);
//nums.Push(34);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
//Queue<int> nums = new Queue<int>();
//nums .Enqueue(1);
//nums .Enqueue(2);
//nums .Enqueue(3);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);


//}
//IEnumerable<int> nums = new List<int>();
//var result=nums.ToList();

//List<int> numbers = new List<int>() { 1, 2, 3, 4, 6,5 };
//List<int> numbers2 = new List<int>() { 2, 5, 6, 7, 8 };
//Console.WriteLine(numbers.Count);

//numbers.Add(1);

//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//Console.WriteLine(numbers[0]);
//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(numbers.FirstOrDefault(m=>m==5));
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
////numbers.Remove(5);
//Console.WriteLine("----------");
//numbers.AddRange(numbers2);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//foreach(var item in AppDbContext.customers)
//{
//    Console.WriteLine(item.FullName);
//}

CustomerController customerController = new CustomerController();
//customerController.GetAll();
//customerController.GetById();
//customerController.GetAllByAge();
customerController.GetACountOfDatas();
