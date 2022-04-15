using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{

    [ServiceContract]
    public interface IEmprunteur
    {
        [OperationContract]
        int Addup();
        [OperationContract]
        bool IsActive();
        [OperationContract]
        emprunteur ListEmprs();
        [OperationContract]
        List<ouvrage> ConsulterOvrg();
        [OperationContract]
        List<ouvrage> chercherOvrg(ouvrage ovrg, String Choix);
        [OperationContract]
        int InscrireListAtt(int codeBarre, string IDEmpr);
        [OperationContract]
        String reserver(string id, int codeBarre);
        [OperationContract]
        emprunteur ConsulterCompte(String ID);
        [OperationContract(Name="modifierCompteEtud")]
        void modifierCompteEtud(etudiant etud);
        [OperationContract(Name = "modifierCompteEns")]
        void modifierCompteEns(enseignant ens);
        [OperationContract]
        String authentifierEtud(String pseudo, String password);
        [OperationContract]
        String authentifierEns(String pseudo, String password);
        [OperationContract]
        List<listeAttente> listeattente(String id);
        [OperationContract]
        List<emprunt> listeemprunt(String id);
        [OperationContract]
        int attendreConfirmation(String id);
        //void notifierParEmail(object source, string email);

    }
}
