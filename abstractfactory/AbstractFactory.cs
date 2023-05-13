
// 八卦炉的精髓方法
using abstractfactory;
using factory;
using System.Reflection;

public abstract class AbstractFactory
{
    // 技能一：创造小人
    public abstract T CreateHuman<T>() where T : class, IHuman;
    // 技能二：创造宠物
    public abstract T CreatePet<T>() where T : class, IPet;
}

// 萧炎升级后的炉子
public class Factory : AbstractFactory
{
    public override T CreateHuman<T>()
    {
        try
        {
            var human = Activator.CreateInstance(typeof(T)) as T;
            return human;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

    public override T CreatePet<T>()
    {
        try
        {
            var pet = Activator.CreateInstance(typeof(T)) as T;
            return pet;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

}
