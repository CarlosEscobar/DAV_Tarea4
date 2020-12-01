using DAV_Tarea4.Proxy;

namespace DAV_Tarea4.Singleton
{
    class Singleton
    {
        private static PieceProxy _pieceProxyInstance;
        protected Singleton(){ }

        public static PieceProxy GetPieceProxy()
        {
            if (_pieceProxyInstance == null)
            {
                _pieceProxyInstance = new PieceProxy();
            }
            return _pieceProxyInstance;
        }
    }
}
