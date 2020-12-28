using System;

namespace SumLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linklist1 = new LinkedLists();
            LinkedLists linklist2 = new LinkedLists();

            linklist1.append(7);
            linklist1.append(1);
            linklist1.append(6);

            linklist2.append(5);
            linklist2.append(9);
            linklist2.append(2);


            SumList(linklist1, linklist2).print();        

        }

        static LinkedLists SumList(LinkedLists l1, LinkedLists l2) {
            LinkedLists answerList = new LinkedLists();
            int carry = 0, valuetoList, resultSum;
            Node node1 = l1.First(), node2 = l2.First();

            while( node1 != null || node2 != null){
              resultSum = 0;
              
              if (node1 != null) {
                resultSum = node1.value;
                node1 = node1.next;
              }
                 
              if (node2 != null) {   
                resultSum += node2.value;
                node2 = node2.next;
              }
                 
              valuetoList = resultSum + carry;
              
              if (valuetoList > 10) {
                valuetoList = valuetoList % 10;
                carry = 1;
              } else {
                carry = 0;
              }

              answerList.append(valuetoList);
            }

            return answerList;
        }
    }
}
