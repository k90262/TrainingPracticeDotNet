namespace PinBall
{
    interface IHittable
    {
        bool HitBy(IHitter hitter);
    }

}