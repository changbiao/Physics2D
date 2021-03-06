﻿using Physics2D.Core;
using Physics2D.Force;
using Physics2D.Force.Zones;

namespace Physics2D.Factories
{
    /// <summary>
    /// 区域作用力工厂
    /// </summary>
    public static class ZoneFactory
    {
        #region 工厂方法

        /// <summary>
        /// 创建一个全局作用力区域
        /// </summary>
        /// <param name="world">物理世界</param>
        /// <param name="particleForceGenerator">作用力发生器</param>
        /// <returns></returns>
        public static GlobalZone CreateGlobalZone(World world, ParticleForceGenerator particleForceGenerator)
        {
            GlobalZone zone = new GlobalZone();
            RegistryZone(world, particleForceGenerator, zone);
            return zone;
        }

        /// <summary>
        /// 创建一个矩形区域作用力
        /// </summary>
        /// <param name="world">物理世界</param>
        /// <param name="particleForceGenerator">作用力发生器</param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static RectangleZone CreateRectangleZone(World world, ParticleForceGenerator particleForceGenerator, float x1, float y1, float x2, float y2)
        {
            RectangleZone zone = new RectangleZone(x1, y1, x2, y2);
            RegistryZone(world, particleForceGenerator, zone);
            return zone;
        }

        #endregion 工厂方法

        #region 私有方法

        /// <summary>
        /// 注册区域
        /// </summary>
        /// <param name="world">物理区域</param>
        /// <param name="particleForceGenerator">作用力发生器</param>
        /// <param name="zone">区域</param>
        private static void RegistryZone(World world, ParticleForceGenerator particleForceGenerator, Zone zone)
        {
            zone.particleForceGenerators.Add(particleForceGenerator);
            world.ZoneSet.Add(zone);
        }

        #endregion 私有方法
    }
}