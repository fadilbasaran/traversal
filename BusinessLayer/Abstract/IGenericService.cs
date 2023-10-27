﻿using System;
namespace BusinessLayer.Abstract
{
	public interface IGenericService<T>
	{
		void TAdd(T t);
		void TUpdate(T t);
		void TDelete(T t);

		List<T> TGetList();

		T TGetByID(int id);
    }
}

