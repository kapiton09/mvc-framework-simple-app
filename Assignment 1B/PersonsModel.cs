using System;
using System.Collections;
using System.Drawing;

namespace Assignment_1B
{
    /// <summary>
	/// Summary description for PersonsModel.
	/// </summary>
    public class PersonsModel
    {
        private ArrayList personList;
        private PersonsController theController;

        public PersonsModel(PersonsController aController)
        {
            personList = new ArrayList();
            theController = aController;
        }

        public ArrayList PersonList
        {
            get
            {
                return personList;
            }
        }

        /// <summary>method: AddPerson
		/// add person to the model and update views
		/// </summary>
		/// <param name="aPerson"></param>
		public void AddPerson(Person aPerson)
        {
            personList.Add(aPerson);
            UpdateViews();
        }

        /// <summary>method: UpdatePerson
		/// update views
		/// </summary>
		/// <param name="aShape"></param>
		public void UpdatePerson(Person aPerson)
        {
            UpdateViews();
        }

        /// <summary>method: DeletePerson
		/// delete shape and update views
		/// </summary>
		/// <param name="aShape"></param>
		public void DeletePerson(Person aPerson)
        {
            personList.Remove(aPerson);
            UpdateViews();
        }

        /// <summary>method: Reset
		/// Clears the arraylist of the person
		/// </summary>
		/// <param name="aShape"></param>
		public void Reset()
        {
            personList.Clear();
            UpdateViews();
        }

        /// <summary>method: SendToBack
		/// method to resequence arrayList so selected Person is 
		/// drawn first
		/// </summary>
		/// <param name="aPerson"></param>
		public void SendToBack(Person aPerson)
        {
            // first person drawn is at the back			
            ArrayList sortList = new ArrayList();
            // find index of person to be drawn first
            int max = personList.IndexOf(aPerson);
            // first person to send to back
            sortList.Add(aPerson);
            // copy to sortList in correct sequence
            for (int i = 0; i < max; i++)
            {
                sortList.Add(personList[i]);
            }

            // copy sortList back to personList
            for (int i = 0; i < sortList.Count; i++)
            {
                personList[i] = sortList[i];
            }
            UpdateViews();
        }

        /// <summary>method: BringToFront
		/// method to resequence arrayList so selected person is 
		/// drawn last
		/// </summary>
		/// <param name="aPerson"></param>
		public void BringToFront(Person aPerson)
        {
            // last person drawn is at the front			
            ArrayList sortList = new ArrayList(personList);
            // find index of person to be drawn last
            int max = personList.IndexOf(aPerson);
            // find length of personList array
            int length = personList.Count;
            // copy personList to sortList excluding selected person
            for (int i = max + 1; i < length; i++)
            {
                sortList[i - 1] = personList[i];
            }
            // last sperson to bring to front
            sortList[length - 1] = personList[max];
            // copy sortList back to personList
            for (int i = 0; i < sortList.Count; i++)
            {
                personList[i] = sortList[i];
            }
            UpdateViews();
        }

        /// <summary>method: UpdateViews
		/// refresh all views
		/// </summary>
		public void UpdateViews()
        {
            theController.UpdateViews();
        }
    }
}
