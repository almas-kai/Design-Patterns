namespace Proxy.Database;

/// <summary>
///     Defines general functionality of databases.
/// </summary>
/// <typeparam name="T">
///     The item to store.
/// </typeparam>
public interface IDatabase<T> {

    /// <summary>
    ///     Returns the record that is associated with the specified <paramref name="index" />.
    /// </summary>
    /// <returns>
    ///     The item at the specified <paramref name="index" />.
    /// </returns>
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///     Thrown when the <paramref name="index" /> is outside of the valid range of indices for the collection.
    /// </exception>
    /// <exception cref="System.Collections.Generic.KeyNotFoundException">
    ///     Thrown when the <paramref name="index" /> is not found in the database.
    /// </exception>
    /// <param name="index">
    ///     The index of the item to find.
    /// </param>
    public T Find(int index);

    /// <summary>
    ///     Adds a new <paramref name="record" /> at the specified <paramref name="index" />.
    /// </summary>
    /// <returns>
    ///     The newly added item.
    /// </returns>
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///     Thrown when the <paramref name="index" /> is outside of the valid range of indices for the collection.
    /// </exception>
    /// <exception cref="System.ArgumentNullException">
    ///     Thrown when the <paramref name="index" /> is <c>null</c>.
    /// </exception>
    /// <param name="index">
    ///     The index at which to store the <paramref name="record" />.
    /// </param>
    /// <param name="record">
    ///     The record that is intended to be stored.
    /// </param>
    public T Add(int index, T record);
}