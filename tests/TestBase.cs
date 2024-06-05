using System.Numerics;

namespace universe_simulator;

public class Basic_Tests
{
    [Fact]
    public void TestAssert()
    {
        Assert.True(true);
    }

    [Fact]
    public void TestCreateUniverse()
    {
        var universe = new cheat.Universe();
        Assert.True(universe.Create(100, 100, 100));
        Assert.NotNull(universe);
    }

    [Fact]
    public void TestRunUniverse()
    {
        var universe = new cheat.Universe();
        universe.Create(100, 100, 100);
        
        var task = universe.Run(100);
        
        Assert.NotNull(task);
        task.RunSynchronously();

        Assert.True(task.IsCompleted);
    }

    [Fact]
    public void TestAddPhoton()
    {
        var universe = new cheat.Universe();
        universe.Create(100, 100, 100);
        
        universe.AddPhoton(100, new Vector3(50, 50, 50), new Vector3(1, 0, 0));
        universe.Run(100).RunSynchronously();
    }

}