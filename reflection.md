# Reflection Örnek

### Nesne Oluşturma
Reflection, derleme zamanında bilinmeyen bir türden nesneler oluşturmanıza olanak sağlar.
Bir türün adını kullanarak bu türün bir örneğini oluşturabilir ve bu örnek üzerinde çalışabilirsiniz.
```
Type type = Type.GetType("Namespace.MyClass");
object instance = Activator.CreateInstance(type);
```
---
### Özelliklere Erişim
Reflection, bir nesnenin özelliklerine erişmek için kullanılabilir.
Özelliklere okuma, yazma ve değerlerini değiştirme gibi işlemler yapabilirsiniz.
``` Type type = typeof(MyClass);
object instance = Activator.CreateInstance(type);
PropertyInfo property = type.GetProperty("MyProperty");
object value = property.GetValue(instance);
```
---

### Method Çağırma
Reflection, bir nesnenin metotlarını çağırmak için kullanılabilir. Metot adını, 
parametrelerini ve dönüş değerini kullanarak metotları çağırabilirsiniz.
```Type type = typeof(MyClass);
object instance = Activator.CreateInstance(type);
MethodInfo method = type.GetMethod("MyMethod");
object result = method.Invoke(instance, new object[] { param1, param2 });
```
---
### Tür bilgilerine erişim
Reflection, bir türün yapısal bilgilerine erişmek için kullanılabilir. Örneğin, sınıfın adını, tür parametrelerini, üye listesini vb. alabilirsiniz.
```
Type type = typeof(MyClass);
string typeName = type.FullName;
Type[] genericArguments = type.GetGenericArguments();
MemberInfo[] members = type.GetMembers();
```
---
### Özniteliklerin analizi
Reflection, bir tür veya üye üzerinde tanımlanmış öznitelikleri analiz etmek için kullanılabilir. Bu, özel davranışlar uygulamak, ek bilgileri almak veya türleri açıklamak için kullanılabilir.
```
Type type = typeof(MyClass);
object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);
foreach (MyAttribute attribute in
```
