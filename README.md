# 漫画算法(小灰的算法之旅)

2022-02-07
===
1. 完成数组  
  数组类的方法包括有InsertArray（插入）、DeleteArray（删除）、Resize（扩容数组容量）以及OutPtuArray（输出）
2. 完成链表  
  链表类的方法包括有Add(添加)、Insert(插入)、Remove(移除)、GetLink(获取)以及OutPut（输出）。
3. 完成队列  
  队列类方法包括：  
    * EnQueue（入队）
    * DeQueue（出队）
    * OutPut（输出队列）
  
2022-02-08
===
1. 完成二叉树  
 二叉树方法包括：  
   * CreateTreeNode（创建二叉树）
   * Traveral（遍历二叉树）
   * preTraveral（前序遍历）
   * inTraveral（中序遍历）
   * postTraveral（后序遍历）
   * stackPreTraveral（堆栈前序遍历）
   * queuePreTraveral（队列层次遍历）  
  
2022-02-09
===
1. 完成二叉堆  
   二叉堆方法包括：  
   * UpAdjust （二叉堆上浮）
   * DownAdjust （二叉堆下沉）
   * buildHeap （构造二叉堆）  
  
2022-02-10
===
1. 完成二叉堆队列(最大堆)  
   方法包括：  
   * EnQueue（入队）  
   * DeQueue（出队）  
   * UpAdjust（上浮）  
   * DownAdjust（下沉）  
   * ReSize（扩容）  
   
2022-02-13
===
1. 冒泡排序  
   学习到的内容主要包括：  
   * 冒泡算法的优化方式，包括设置已序标记和排序边界  
2. 鸡尾酒排序(从冒泡衍生)  
   了解到鸡尾酒的算法原理，是如何从冒泡改进过来的，相比冒泡算法优势。鸡尾酒相比冒泡最大的改变是，冒泡每一轮会单纯只从左边开始，而鸡尾酒一轮从左边开始，直达末尾后，直接从右边开始往左。  
  
2022-02-15
===  
1. 快速排序  
   双边循环法、单边循环法以及非递归实现  

2022-02-16
===
1. 堆排序  
   在二叉堆基础上而来，例如最大堆，每次删去顶点，经过自我堆调整，新顶点就是仅次于旧顶点的数。  
  
2022-02-19
===
1. 计数排序  
   原理是对数组中的每个数按其值进行统计，先在未排序的数组中找到最大的值，建立一个大小为值+1的计数数组，接着过一遍未排序数组，统计对应的值的数量。最后按照计数数组进行排序数组。  
   * 优化：有一种极端情况比如数组中只存在90-95之间的，就会导致前90的空间全浪费吊。优化思路是可以选取最大和最小的数，获得区间，根据做个区间去建立计数数组。同时为了区分相同值的在排序后数组的位置，把计数数组进行二次处理，即第二位开始，自己的值加上前面一位的值作为新值保存下来。在进行输出排序数组时，按原来数组从后往前开始。
2. 桶排序  
   一个桶代表一个区间，桶的数量自定，这里是直接是数组的长度。先找到最大最小数，按桶的数量确定每个桶的区间，然后把数组的数按要求存放在对应的桶区间内。放完后，对每个桶进行排序。最后逐个按桶输出就是排序后的数组。
  
2022-02-21
===
1. 判断链表是否有环  
   设置两个指针，p1和p2，让这两个指针以分别1步和2步的速度向前走，如果存在循环，这两个指针必定会有相碰的时候，这时候p1=P2，就可以判断出来该链表就是有环的。  
  
2022-02-22
===
1. 最小栈  
   除了原本的栈，在此基础之上增加一个辅助栈，辅助栈除了为空时直接放入一个值，其他时候存放的条件是比栈顶要小才可以放入。  
   
2022-02-23  
===
1. 最大公约数  
   有辗转相除法和更相减损术，第一种碰到大数时%取余效率差，第二种碰到10000和1这种极端效率也差。把二者结合起来就是现在实现的代码。假设有a和b，当a和b都是偶数时，两者二进制数分别向右移动一位，也就是除以2，递归调用GCD函数。同理，当二者一个偶数一个奇数时，偶数那个除2，奇数不变，继续递归。当二者同时为奇数时，小的作为新的数a，大的减去小的得到的数作为新的数b，继续调用GCD递归下去。当二者相等时，即这个数就是最大公约数，结束。  
  
2022-02-24
===
1. 判断一个数是否为2的整数次幂  
   原理是因为2的次方转换成二进制都是1开头，后面跟着n个0(n>=0)，二进制数减1就是为全1的数，把这个数与原来的二进制数相与，得到的结果必定为0。