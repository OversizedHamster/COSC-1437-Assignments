using System;
using System.Collections.Generic;
using System.Text;

/*
 * ProfReynolds
 */

namespace LinkedListDemonstrator
{

    /// <summary>
    /// A node in the LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NodeDemonstrator<T>
    {
        /// <summary>
        /// The node value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The next node in the linked list (null if last node)
        /// </summary>
        public NodeDemonstrator<T> Next { get; set; }

        /// <summary>
        /// The previous node in the linked list (null if last node)
        /// </summary>
        public NodeDemonstrator<T> Previous { get; set; }

    }
}
