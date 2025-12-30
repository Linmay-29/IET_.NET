
using FoodOrderSystem.DAL;
using FoodOrderSystem.Models;

UserDBContext UDBContext = new UserDBContext();
MealDBContext MealDB = new MealDBContext();

int opChoice = 0;
do
{
    Console.WriteLine("1.Login\n2.Register\n3.Forgot Password\n4.Delete Account\n5.Exit\nSelect Option");
    opChoice = Convert.ToInt32(Console.ReadLine());
    int noOfRowsAffected = 0;
    switch (opChoice) 
    {
        case 1:
            Console.WriteLine("Enter Username :");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            string upass = Console.ReadLine();

            var isPresent = UDBContext.ValidateUser(uname, upass);
            if (isPresent != null)
            {
                if (isPresent.URole == "admin")
                {
                    Console.WriteLine("Welcome Admin");
                    Meal mealToBeInserted = new Meal();
                    Console.WriteLine("Enter name of meal :");
                    mealToBeInserted.Name = Console.ReadLine();
                    Console.WriteLine("Enter type (Veg/Non-Veg) :");
                    mealToBeInserted.Type = Console.ReadLine();
                    Console.WriteLine("Enter Price :");
                    mealToBeInserted.Price = Convert.ToDecimal(Console.ReadLine());

                    noOfRowsAffected = MealDB.InsertMeal(mealToBeInserted);
                    if (noOfRowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted Successfully.");
                    }
                    else 
                    {
                        Console.WriteLine("Data was not inserted.");
                    }

                }
                else 
                {
                    Console.WriteLine("------Menu------");
                    List<Meal> mealList= MealDB.GetMeals();
                    Console.WriteLine("------Veg------");
                    foreach (Meal meal in mealList)
                    {
                        if(meal.Type == "Veg")
                        Console.WriteLine($"{meal.Id}. {meal.Name} ({meal.Type}) - Rs.{meal.Price}");
                    }
                    Console.WriteLine("------Non-Veg------");
                    foreach (Meal meal in mealList)
                    {
                        if (meal.Type == "Non-Veg")
                            Console.WriteLine($"{meal.Id}. {meal.Name} ({meal.Type}) - Rs.{meal.Price}");
                    }

                    Console.WriteLine("\nEnter meal ids you want to order (Comma Separated)");
                    string selectedIds = Console.ReadLine();
                    List<Meal> selectedMeals = new List<Meal>();
                    string[] selectedIdsArr = selectedIds.Split(',');
                    foreach (string id in selectedIdsArr)
                    {
                        foreach (Meal meal in mealList)
                        {
                            if (meal.Id == Convert.ToInt32(id.Trim()))
                            {
                                selectedMeals.Add(meal);
                            }
                        }
                    }

                    Console.WriteLine("------Final Bill------");
                    decimal total = 0;
                    foreach (Meal meal in selectedMeals)
                    {
                        Console.WriteLine($"{meal.Name}({meal.Type}) - RS. {meal.Price}");
                        total += meal.Price;
                    }
                    Console.WriteLine($"Total Amount : {total}");


                }
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }
            break;
        case 2:
            User userToBeRegister = new User();
            Console.WriteLine("Enter your username :");
            userToBeRegister.UName = Console.ReadLine();
            Console.WriteLine("Set Password :");
            userToBeRegister.UPass = Console.ReadLine();
            Console.WriteLine("Enter your email :");
            userToBeRegister.UEmail = Console.ReadLine();
            noOfRowsAffected = UDBContext.InsertUser(userToBeRegister);
            if (noOfRowsAffected > 0)
            {
                Console.WriteLine("Registeration Done. Now you can login.");
            }
            else
            {
                Console.WriteLine("Error. Plz register again.");
            }
                break;
        case 3:
            Console.WriteLine("Enter email for verification :");
            string email = Console.ReadLine();
            User user = UDBContext.GetUserByEmail(email);
            if (user != null)
            {
                Console.WriteLine("Enter new password :");
                string pass = Console.ReadLine();
                noOfRowsAffected = UDBContext.ChangePassword(email,pass);
                if (noOfRowsAffected > 0)
                {
                    Console.WriteLine("Password changed sucessfully.");
                }
                else {
                    Console.WriteLine("Password didn't changed. Try again.");
                }
            }
            else {
                Console.WriteLine("Invalid email. Plz try another email");
            }
            break;
        case 4:
            User userToBeDeleted = new User();
            Console.WriteLine("Enter Username :");
            userToBeDeleted.UName = Console.ReadLine();
            Console.WriteLine("Enter Password :");
            userToBeDeleted.UPass = Console.ReadLine();
            noOfRowsAffected = UDBContext.DeleteAccount(userToBeDeleted);
            if (noOfRowsAffected > 0)
            {
                Console.WriteLine("Account deleted sucessfully.");
            }
            else
            {
                Console.WriteLine("Acount was not deleted. Plz try again.");
            }
            break;
        case 5:
            Console.WriteLine("Thanks for visiting...");
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }

}while (opChoice != 5);