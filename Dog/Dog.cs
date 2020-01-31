using System;

namespace Dog
{
    class Dog
    {
		private int age;
		private String name;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Dog()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, String name)
		{

			this.SetAge(age);
			this.SetName(name);

		}//end constructor

		public int CalcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int GetAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void SetAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String GetName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void SetName(String name)
		{
			bool valid = true;
			char[] n = name.ToCharArray();

			foreach (char c in n)
			{
				if (!char.IsLetter(c))
				{
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";

		}//end setName

		public override String ToString()
		{
			return "Dog [age=" + age + ", name=" + name + "]";
		}//end toString
	}
}
