namespace DSA_cs_2025.Arrays;


// DSA-cs-2025 for the Arrays Practice
public class MainClass
{
    public void Run()
    {
        //? create an array
        // int[] arr = new int[3];
        //? assign values to the array
        // arr[0] = 1;
        // arr[1] = 2;
        // arr[2] = 3;
        //? print the array
        // foreach (var t in arr)
        // {
        //     Console.WriteLine(t);
        // }
        
        // create an array for reverse, find element, swap, and find max value in the array
        int[] arr2 = [1, 2, 3, 4, 5, 6];
        
        //* Reverse the array
        // before reverse
        PrintArray(arr2, "Before Reverse");
        // reverse the array
        ReverseArray(arr2);
        // after reverse
        PrintArray(arr2, "After Reverse");
        
        //* find an element in the array
        Console.WriteLine();
        int element = 3;
        int index = FindElement(arr2, element);
        Console.WriteLine($"Element {element} found at index {index}");
        
        //* find the maximum value in the array
        Console.WriteLine();
        int max = FindMaxValue(arr2);
        Console.WriteLine($"Max value in the array is {max}");
        
        //* find the maximum value in the array with the given range
        Console.WriteLine();
        int start = 1;
        int end = 3;
        int maxInRange = FindMaxValueInRange(arr2, start, end);
        Console.WriteLine($"Max value in the array from index {start} to {end} is {maxInRange}");
    }
    
    // Reverse the array
    private void ReverseArray(int[] arr)
    {
        // Check if the array is null or empty
        if (arr.Length == 0)
        {
            return;
        }
        // Initialize the start index to the beginning of the array
        int start = 0;
        // Initialize the end index to the last element of the array
        int end = arr.Length - 1;
        
        // Loop until the start index is less than the end index
        while (start < end)
        {
            // Swap the elements at the start and end indices
            (arr[start], arr[end]) = (arr[end], arr[start]);
            // Move the start index forward
            start++;
            // Move the end index backward
            end--;
        }
    }
    
    // Find an element in the array
    private int FindElement(int[] arr, int element)
    {
        // Loop through the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Check if the current element is equal to the target element
            if (arr[i] == element)
            {
                // Return the index of the element
                return i;
            }
        }
        // Return -1 if the element is not found
        return -1;
    }
    
    // Find the maximum value in the array
    private int FindMaxValue(int[] arr)
    {
        // Check if the array in empty
        if (arr.Length == 0)
        {
            return -1;
        }
        // Initialize the max value to the first element of the array
        int max = 0; // assume the first element is the max for now
        // Loop through the array
        foreach (var t in arr)
        {
            // Check if the current element is greater than the max value
            if (t > max)
            {
                // Update the max value
                max = t;
            }
        }
        // Return the max value
        return max;
    }
    
    //Find the maximum value in the array with the given range
    private int FindMaxValueInRange(int[] arr, int start, int end)
    {
        // Check if the array in empty
        if (arr.Length == 0)
        {
            return -1;
        }
        // Initialize the max value to the first element of the array
        int max = 0; // assume the first element is the max for now
        // Loop through the array
        for (int i = start; i <= end; i++)
        {
            // Check if the current element is greater than the max value
            if (arr[i] > max)
            {
                // Update the max value
                max = arr[i];
            }
        }
        // Return the max value
        return max;
    }
    
    // Print the array
    private void PrintArray(int[] arr, String message = "")
    {
        Console.WriteLine();
        Console.WriteLine(message);
        foreach (var i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}