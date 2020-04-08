namespace HomeWork8
{
    public class ArrayHelperClass
    {
        static class ArrayHelper{
            static string Pop(ref string[] arr){
                string value = arr [arr.Length-1];
                string[] newArr = new string[arr.Length-1];
                for (int i = 0; i < newArr.Length; i++){
                    newArr[i] = arr[i];
                }
                arr = newArr;
                return value;
            }
            static int Pop(ref int[] arr){
                int value = arr [arr.Length-1];
                int[] newArr = new int[arr.Length-1];
                for (int i = 0; i < newArr.Length; i++){
                    newArr[i] = arr[i];
                }
                arr = newArr;
                return value;
            }
            static double Pop(ref double[] arr){
                double value = arr [arr.Length-1];
                double[] newArr = new double[arr.Length-1];
                for (int i = 0; i < newArr.Length; i++){
                    newArr[i] = arr[i];
                }
                arr = newArr;
                return value;
            }
            static decimal Pop(ref decimal[] arr){
                decimal value = arr [arr.Length-1];
                decimal[] newArr = new decimal[arr.Length-1];
                for (int i = 0; i < newArr.Length; i++){
                    newArr[i] = arr[i];
                }
                arr = newArr;
                return value;
            }
            static float Pop(ref float[] arr){
                float value = arr [arr.Length-1];
                float[] newArr = new float[arr.Length-1];
                for (int i = 0; i < newArr.Length; i++){
                    newArr[i] = arr[i];
                }
                arr = newArr;
                return value;
            }
            
        }
    }
}