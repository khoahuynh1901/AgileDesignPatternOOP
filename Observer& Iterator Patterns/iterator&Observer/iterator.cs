using iterator_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace iterator_Observer
{
    interface IIterator
    {
        string FirstItem { get; }
        string NextItem { get; }
        string CurrentItem { get; }
        bool IsDone { get; }
    }
    interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }
    class MyAggregate : IAggregate
    {
        List<string> values_ = null;
        public MyAggregate()
        {
            values_ = new List<string>();
        }
        #region IAggregate Members
        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }
        #endregion
        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < values_.Count)
                {
                    return values_[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }

            set
            {
                values_.Add(value);
            }
        }
        public int Count
        {
            get
            {
                return values_.Count;
            }
        }
    }
    class MyIterator : IIterator
    {
        IAggregate aggregate_ = null;
        int currentIndex_ = 0;
        public MyIterator(IAggregate aggregate)
        {
            aggregate_ = aggregate;
        }
        #region IIterator Members
        public string FirstItem
        {
            get
            {
                currentIndex_ = 0;
                return aggregate_[currentIndex_];
            }
        }
        public string NextItem
        {
            get
            {
                currentIndex_ += 1;
                if (IsDone == false)
                {
                    return aggregate_[currentIndex_];
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public string CurrentItem
        {
            get
            {
                return aggregate_[currentIndex_];
            }
        }
        public bool IsDone
        {
            get
            {
                if (currentIndex_ < aggregate_.Count)
                {
                    return false;
                }
                return true;
            }
        }
        #endregion

    }
}
