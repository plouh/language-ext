using System;

namespace LanguageExt
{
    public static partial class Prelude
    {
        /// <summary>
        /// Append an extra item to the tuple
        /// </summary>
        public static Tuple<T1, T2, T3> append<T1, T2, T3>(Tuple<T1, T2> self, T3 third) =>
            self.Append(third);

        /// <summary>
        /// Sum
        /// </summary>
        public static int sum<T1, T2>(Tuple<int, int> self) =>
            self.Sum();

        /// <summary>
        /// Sum
        /// </summary>
        public static double sum<T1, T2>(Tuple<double, double> self) =>
            self.Sum();

        /// <summary>
        /// Sum
        /// </summary>
        public static float sum<T1, T2>(Tuple<float, float> self) =>
            self.Sum();

        /// <summary>
        /// Sum
        /// </summary>
        public static decimal sum<T1, T2>(Tuple<decimal, decimal> self) =>
            self.Sum();

        /// <summary>
        /// Map to R
        /// </summary>
        public static R map<T1, T2, R>(Tuple<T1, T2> self, Func<T1, T2, R> map) =>
            self.Map(map);

        /// <summary>
        /// Map to tuple
        /// </summary>
        public static Tuple<R1, R2> map<T1, T2, R1, R2>(Tuple<T1, T2> self, Func<Tuple<T1, T2>, Tuple<R1, R2>> map) =>
            self.Map(map);

        /// <summary>
        /// Bi-map to tuple
        /// </summary>
        public static Tuple<R1, R2> map<T1, T2, R1, R2>(Tuple<T1, T2> self, Func<T1, R1> firstMap, Func<T2, R2> secondMap) =>
            self.Map(firstMap, secondMap);

        /// <summary>
        /// Iterate
        /// </summary>
        public static Unit iter<T1, T2>(Tuple<T1, T2> self, Action<T1> first, Action<T2> second) =>
            self.Iter(first, second);

        /// <summary>
        /// Iterate
        /// </summary>
        public static Unit iter<T1, T2>(Tuple<T1, T2> self, Action<T1, T2> func)
        {
            func(self.Item1, self.Item2);
            return Unit.Default;
        }

        /// <summary>
        /// Fold
        /// </summary>
        public static S fold<T1, T2, S>(Tuple<T1, T2> self, S state, Func<S, T1, T2, S> fold) =>
            self.Fold(state, fold);

        /// <summary>
        /// Bi-fold
        /// </summary>
        public static S fold<T1, T2, S>(Tuple<T1, T2> self, S state, Func<S, T1, S> firstFold, Func<S, T2, S> secondFold) =>
            self.Fold(state, firstFold, secondFold);

        /// <summary>
        /// Bi-fold back
        /// </summary>
        public static S foldBack<T1, T2, S>(Tuple<T1, T2> self, S state, Func<S, T2, S> firstFold, Func<S, T1, S> secondFold) =>
            self.FoldBack(state, firstFold, secondFold);
    }
}