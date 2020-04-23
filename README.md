# Reface.AppStarter.NPI.SqlServer

! 所有功能已全部合并到 Reface.AppStarter.NPI 中

! 所有功能已全部合并到 Reface.AppStarter.NPI 中

! 所有功能已全部合并到 Reface.AppStarter.NPI 中

---

Reface.AppStarter.NPI 面向 SqlServer 的实现

## 使用方法

1. 添加 *SqlServerNpiAppModule*

```csharp
[SqlServerNpiAppModule]
public class TestAppModule : AppModule
{
}
```

2. 向配置文件添加 section 并配置数据库连接字符串

```json
// app.json
{
    "SqlServer" : {
        "ConnectionString" : "your connection string here"
    }
}
```

3. 编写实体

```csharp
using System.ComponentModel.DataAnnotations.Schema;

[Table]
public class User
{
    public int Id { get; set; }
}
```

4. 编写 Dao 接口

```csharp
[NpiDao]
public interface IUserDao : INpiDao<User>
{
    User SelectById(int id);
    IList<User> SelectOrderbyId();
}
```

5. 使用

通过 IOC / DI 组件，直接注入 IUserDao 即可使用

```csharp
[Component]
public class SomeClass : ISomeInterface
{
    private readonly IUserDao userDao;

    public SomeClass(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    public void showUsers()
    {
        foreach(var user in this.userDao.SelectOrderbyId())
        {
            Console.WriteLine(user.Id);
        }
    }
}
```