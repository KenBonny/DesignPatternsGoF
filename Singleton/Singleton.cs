using System;

namespace Singleton
{
    /// <summary>
    /// Threadsafe singleton.
    /// Watch out that you don't use the Instance in a non threadsafe way!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T>
        where T: class, new()
    {
        private static readonly Lazy<T> Lazy = new Lazy<T>(() => new T());

        public static T Instance { get { return Lazy.Value; } }

        private Singleton()
        {
        }
    }
}