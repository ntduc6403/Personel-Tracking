﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class PositionBLL
    {
        public static void AddPosition(POSITION position)
        {
           PositionDao.AddPosition(position);
        }

        public static List<PositionDTO> GetPosition()
        {
            return PositionDao.GetPosition();
        }
    }
}
