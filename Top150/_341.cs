namespace Top150;

public class NestedIterator
{
        public IList<NestedInteger> NestedList { get; set; }     
        private int Pointer { get; set; }
        private int Length { get; set; } = 0;
        private List<int> IntegerList = [];
        public NestedIterator(IList<NestedInteger> nestedList)
        { 
                this.NestedList = nestedList;
                Pointer = 0;
                ConvertToList(nestedList);
                Length = CalculateLength();
        }

        private void ConvertToList(IList<NestedInteger> list)
        {
                foreach (var element in list)
                {
                        if (element.GetList() == null && element.GetInteger() == null)
                        {
                                return;
                        }

                        if (element.IsInteger())
                        {
                               IntegerList.Add(element.GetInteger());
                        }
                        else
                        {
                                ConvertToList(element.GetList());
                        }
                }
        }
        private int CalculateLength()
        {
                return IntegerList.Count;
        }
        public bool HasNext()
        {
                if (Pointer < Length)
                {
                        return true;
                }

                return false;

        }

        public int Next()
        {
               var element = IntegerList[Pointer];
                Pointer++;
                return element;
        }
}

public interface NestedInteger
{
        bool IsInteger();
        int GetInteger();
        IList<NestedInteger> GetList();
}