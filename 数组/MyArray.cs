using static System.Console;
namespace 数组
{
    public class MyArray
    {
        private int[] _array;
        private int _size;
        public MyArray(int size)
        {
            this._array = new int[size];
            this._size = 0;
        }
        //对数组进行扩容
        public void Resize()
        {
            int[] _arrayNew = new int[_array.Length * 2];
            Array.Copy(this._array, _arrayNew, _array.Length);
            this._array = _arrayNew;
        }
        //插入一个数组元素
        public void InsertArray(int index, int element)
        {
            if (index < 0 || index > this._size)
            {
                throw new Exception("超出范围！");
            }
            if (this._size >= _array.Length)
            {
                this.Resize();
            }
            for (int i = this._size - 1; i >= index; i--)
            {
                this._array[i + 1] = this._array[i];
            }
            this._array[index] = element;
            this._size++;
        }
        //删除一个数组元素
        public void DeleteArray(int index)
        {
            if (index < 0 || index > this._size)
            {
                throw new Exception("超出范围！");
            }
            for (var i = index; i < this._size - 1; i++)
            {
                this._array[i] = this._array[i + 1];
            }
            this._size--;
        }
        //输出元素
        public void OutPutArray()
        {
            for (var i = 0; i < this._size; i++)
            {
                Write(this._array[i]);
                Write("  ");
            }
            WriteLine();
        }
        public int Size
        {
            get
            {
                return this._size;
            }
        }
    }
}