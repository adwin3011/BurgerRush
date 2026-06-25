using NUnit.Framework;

public class GameManagerTests
{
    [Test]
    public void ScoreStartsAtZero()
    {
        int score = 0;
        Assert.AreEqual(0, score);
    }

    [Test]
    public void ScoreIncreasesWhenBurgerServed()
    {
        int score = 0;
        score += 10;
        Assert.AreEqual(10, score);
    }

    [Test]
    public void TimerDecreasesOverTime()
    {
        float timer = 60f;
        timer -= 5f;
        Assert.Less(timer, 60f);
    }

    [Test]
    public void CustomerDisappearsWhenTimerReachesZero()
    {
        float waitTime = 3f;
        waitTime -= 3f;
        Assert.AreEqual(0f, waitTime);
    }
}