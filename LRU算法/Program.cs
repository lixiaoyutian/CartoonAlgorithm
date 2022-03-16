using LRU算法;
using static System.Console;

LRUCache LRUCache = new LRUCache(5);
LRUCache.Put("001", "用户1的信息");
LRUCache.Put("002", "用户2的信息");
LRUCache.Put("003", "用户3的信息");
LRUCache.Put("004", "用户4的信息");
LRUCache.Put("005", "用户5的信息");
LRUCache.Get("002");
LRUCache.Put("006", "用户6的信息");
LRUCache.Put("007", "用户7的信息");

WriteLine(LRUCache.Get("001"));
WriteLine(LRUCache.Get("003"));
WriteLine(LRUCache.Get("004"));