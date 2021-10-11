# SpreadArrayCSharp
## Spread Array CSharp
The spread operator is denoted by three dots (…)(popular in javascript). · The spread operator unpacks elements of iterable objects such as arrays, sets, and maps into a list.

### Example
```
var user = new User("Alexandre");
var userAddress = new UserAddress("Porto Velho", "Brasil");
var contact = new Contact("my@mail.com");

dynamic dynamicUserProfile = new ExpandoObject();
dynamicUserProfile = user.Spread(userAddress).Spread(contact);

/// Example 1: preparing to json response
JObject json = JObject.FromObject(new { dynamicUserProfile });

/// Example 2: setting value on richTextBox from windows application
richTextBox1.Text = json.SelectToken("dynamicUserProfile").ToString();
```


```
    public class UserAddress
    {
        public UserAddress(string city, string country)
        {
            City = city;
            Country = country;
        }

        public string City { get; set; }
        public string Country { get; set; }
    }

    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class Contact
    {
        public Contact(string email)
        {
            Email = email;
        }

        public string Email { get; set; }
    }
```
