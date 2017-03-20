using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // printnum();
            // printodd();
            // printsum();
            // iteratarray();
            // printmax();
            // printavg();
            // printarrodd();
            // printGreaterthanY();
            // printsquare();
            // eliminateNeg();
             printMaxMinAvg();
            //  printString();
            //  shiftvalues(new int[] {1,2,3,4,5});

        }
        public static void printnum()
        {
            for(int i=1; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void printodd()
        {
            for(int i=1; i<226; i++){
                if (i%2!=0){
                    Console.WriteLine(i);
                }
            }
        

        }
        public static void printsum(){
            int sum = 0;
            for(int i=0; i<226; i++){
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
        public static void iteratarray(){
            int [] x = new int[] {1,3,5,7,9,13};
            foreach(int num in x){
                Console.WriteLine(num);
            }
        }
        public static void printmax(){
            int[] arr = new int[] {-8,-3,-4,-1,1,3,0,-1};
            int max = arr[0] ;
            for(int i = 0; i<arr.Length; i++){
                if(max < arr[i]){
                max = arr[i];
                }
            }
            System.Console.WriteLine(max);
        }
        public static void printavg(){
            int[] arr = new int[] {3,3,4,2};
            int sum = 0;
            for(int i = 0; i<arr.Length; i++){   
                sum = sum + arr[i];        
             }
             Console.WriteLine(Math.Abs(sum/arr.Length));
        }
        public static void printarrodd(){
           
            for(int i =0 ;i<246;i++){
                 if(i%2!=0){
                    //  Console.WriteLine(i);
                   int[] arr = new int[] {i};
                    foreach(int num in arr ){
                        Console.Write(num);
                          }
                    }
                 }                 
            }
        public static void printGreaterthanY(){
            int temp = 0;
            int count = 0;
            int y = 1;
            int[] arr = new int[]{5,6,9,13,3};
            for(int i=0; i<arr.Length; i++){
                if (arr[i]>y){
                   count = count+1;                   
                }          
            }
            Console.Write(count);
        }
        public static void printsquare(){
            int[] arr = new int[]{5,6,9,13,3};
            for(int i=0; i<arr.Length; i++){
                arr[i] = arr[i]* arr[i];
                Console.WriteLine(arr[i]);
            }
        }
         public static void eliminateNeg(){
            int[] arr = new int[]{5,-6,9,-13,3};
            for(int i=0; i<arr.Length; i++){
            if (arr[i] < 0){
                arr[i]=0;
            }
            Console.WriteLine(arr[i]);
            }
        }
         public static void printMaxMinAvg(){
            int[] arr = new int[] {8,3,4,-1,1,3,0,-1};
            int max = arr[0] ;
            int min = arr[0];
            int sum = 0;
            for(int i = 0; i<arr.Length; i++){
                if(max < arr[i]){
                max = arr[i];
                }
                 if(min > arr[i]){
                    min = arr[i];
                }
                sum += arr[i];
            }
            System.Console.WriteLine("max is {0}, Min is{1}, sum{2}", max,min,sum);
        }
        public static void printString(){
            
             int[] arr = new int[]{5,-6,9,-13,3};
            for(int i=0; i<arr.Length; i++){
            if (arr[i] < 0){
            System.Console.WriteLine("Dojo");
            }
            else{
            System.Console.WriteLine(arr[i]);
            }
            }

        }

        public static void shiftvalues(int[] arr){
    
            for(int i = 0; i<arr.Length-1; i++){
                arr[i]=arr[i+1];
            }
            arr[arr.Length-1] = 0;
            foreach(int i in arr){
                Console.WriteLine(i);
            }
            

        }

}
}




