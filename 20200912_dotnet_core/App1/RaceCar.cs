class RaceCar : Car
{
    // new: create child's own method
    public new void SpeedUp(int no)
    {
        this.Speed += no * 2;
    }
}