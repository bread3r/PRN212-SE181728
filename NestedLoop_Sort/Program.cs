void swap(ref int x, ref int y)
{
    int tmp = x;
    x = y;
    y = tmp;
}

void sort_array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
        }
    }
}

int[] values = new int[10];
void create_array(int[] values)
{
    Random rd = new Random();
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = rd.Next(100);
    }
}
void print_array(int[] values)
{
    foreach (var value in values)
    {
        Console.WriteLine($"{value}\t");
    }
}
//create_array(values);
//print_array(values);
//sort_array(values);
//Console.WriteLine("\nAFTER SORTING: ");
//print_array(values);


void sort_array_while(int[] arr)
{
    int i = 0;
    int j;
    while (i < arr.Length)
    {
        j = i + 1;
        while (j < arr.Length)
        {
            if (arr[i] < arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
    }
}
create_array(values);
print_array(values);
sort_array_while(values);
Console.WriteLine("\nAFTER SORTING: ");
print_array(values);

void sort_array_dowhile(int[] arr)
{
    int i = 0;
    int j;
    do
    { 
        j = i + 1;
        do
        {
            if (arr[i] < arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length-1);
        i++;
    } while (i < arr.Length-1);
    
}
create_array(values);
print_array(values);
sort_array_dowhile(values);
Console.WriteLine("\nAFTER SORTING: ");
print_array(values);