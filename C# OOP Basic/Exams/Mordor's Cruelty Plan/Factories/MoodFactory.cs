public class MoodFactory
{

   public Mood GetMood(int points)
    {
        if (points<-5)
        {
            return new Angry("Angry");
        }
        else if (points<=0)
        {
            return new Sad("Sad");
                    }
        else if (points<15)
        {
            return new Happy("Happy");
        }
        else
        {
            return new JavaScript("JavaScript");
        }
    }

}
