using System;

public class Statistician
{
	public Statistician(double sum_ = 0.0, int length_ = 0, double last_ = 0.0, double largest_ = 0.0, double smallest_ = 0.0)
	{
        sum = sum_;
        length = length_;
        last = last_;
        largest = largest_;
        smallest = smallest_;
	}
    public void clear()
    {
        sum = 0.0;
        length = 0;
    }
    public void next_number(double next_number)
    {
        if (length == 0)
        {
            largest = next_number;
            smallest = next_number;
        }
        sum += next_number;
        length += 1;
        last = next_number;
        if (next_number > largest)
            largest = next_number;
        if (next_number < smallest)
            smallest = next_number;
    }
    public double getSum()
    {
        return sum;
    }
    public int getLength()
    {
        return length;
    }
    public double getLast()
    {
        if (length != 0)
            return last;
        else
            return 0.0;
    }
    public double getLargest()
    {
        if (length != 0)
            return largest;
        else
            return 0.0;
    }
    public double getSmallest()
    {
        if (length != 0)
            return smallest;
        else
            return 0.0;
    }
    public double computeMean()
    {
        if (length != 0)
            return sum / length;
        else
            return 0.0;
    }
    public String name;
    private double sum;
    private int length;
    private double last;
    private double largest;
    private double smallest;
}

Statistician operator +(Statistician s1, Statistician s2)
{
    double largest_;
    double smallest_;
    if (s1.getLargest() > s2.getLargest())
        largest_ = s1.getLargest();
    else
        largest_ = s2.getLargest();
    if (s1.getSmallest() < s2.getSmallest())
        smallest_ = s1.getSmallest();
    else
        smallest_ = s2.getSmallest();
    return new Statistician(s1.getSum() + s2.getSum(), s1.getLength() + s2.getLength(), s2.getLast(), largest_, smallest_);
}