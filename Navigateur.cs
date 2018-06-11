/* 2015/12/11
 *   ============================
 *
 *      Cette partie est le navigateur. Je l'ai déplacé dans une forme pour qu'on puisse l'agrandir et que ce soit plus visible.
 *
 *   ============================
 *
 * */

using System.Windows.Forms;

namespace searchGoogle
{
    public partial class navigateurFenetre : Form
    {
        public navigateurFenetre()
        {
            InitializeComponent();
            wb_seeRes.ScriptErrorsSuppressed = true;
        }

        public void nomFenetre(string nom)
        {
            string nomDeLaFenetre = nom;

            this.Text = nom;
        }
    }
}