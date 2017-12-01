
namespace BallApplication.Models
{
    public class BallModel
    {
        public BallModel(int id)
        {
            this._ballId = id;
        }

        /// <summary>
        /// id
        /// </summary>
        public int BallId
        {
            get
            {
                return this._ballId;
            }
        }
        private int _ballId;
    }
}
