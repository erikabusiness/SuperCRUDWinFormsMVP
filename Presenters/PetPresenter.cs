using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperCRUDWinFormsMVP.Models;
using SuperCRUDWinFormsMVP.Views;

namespace SuperCRUDWinFormsMVP.Presenters
{
    public class PetPresenter
    {
        //fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        //Construtor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //escutando os eventos da view
            this.view.ProcurarEvent += SearchPet;
            this.view.EditarEvent += LoadSelectedPetToEdit;
            this.view.DeletarEvent += DeleteSelectedPet;
            this.view.SalvarEvent += SavePet;
            this.view.CancelarEvent += CancelAction;
            //set pet list binding source
            this.view.SetListaPetBindingSource(petsBindingSource);
            //load pet list view
            LoadAllPetList();
            //Show view
            this.view.Show();
        }

        //methods
        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList; //set data source
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.ProcurarValor);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.ProcurarValor);
            else petList = repository.GetAll();
            petsBindingSource.DataSource=petList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
