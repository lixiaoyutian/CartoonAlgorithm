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

2022-02-28
===  
1. 无序数组排序后的最大相邻差  
  有三种方法，第一种是先排序然后逐个计算得出相差最大的值。第二种是计数排序，得到最大值和最小值，计算出区间，根据区间建立数组，循环数组时，值减去min就是对应的数组下标+1，最后循环计数数组，判断0值出现最多的次数，这个就是最大相邻差。第三种是利用桶排序的原理，计算出每个桶的最大值和最小值，最大相邻差就是一个桶的最大值和它右边桶的最小值的相差。  
   
2022-03-01  
===  
1. 用栈实现队列  
  原理是利用两个栈，第一个栈在入队时，正常存放，直到要出队时，就把第一个栈逐个放入到第二个栈中，再把第二个栈的栈顶出栈，就达到了队列的效果。  
  
2022-03-02
===
1. 寻找全排列的下一个数  
   从后往前，找到逆序的边界，并记录下来，接着把该边界的前一个数，和该逆序区域中最小的比它大的数进行交换，最后把逆序区域进行逆序，使其成为正序，便得到这个数的下一个全排列的数。  
    
2022-03-03
===
1. 删去K个数字后的最小值  
   原理是从左到右巡回，新建的一个栈，当发现一个数比右边的大时，就把右边的数入栈，原来的数出栈，依次循环下去，删掉k个数字后，排除掉开头为0的数字，剩下便是最小值。  
  
2022-03-08
===
1. 大整数相加  
   建立两个数组，把数字逆序并转为整型，逐个相加，大于等于10就进一位，最后得到的数组找到第一位不是0的高位，逆序并输出。  
  
2022-03-09
===  
1. 金矿问题  
   动态规划的原理，找到状态转移方程，利用其方程就可求得结果。可以想象有一个二维数组，列代表工人数量从1到10，行代表第几个金矿。其方程描述的就是选择当前矿和不选择当前矿，如果选择当前矿，就把上一个最优解加上。如果不选择当前的矿，其解就是上一个的最优解。