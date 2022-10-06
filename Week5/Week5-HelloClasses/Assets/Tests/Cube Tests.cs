using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTests
{
    // Test the default constructor
    [Test]
    public void CubeDefaultConstructorTest()
    {
        // Setup and Act
        Cube defaultCube = new Cube();

        // Assert
        Assert.AreEqual(1, defaultCube.GetHeight());
        Assert.AreEqual(1, defaultCube.GetWidth());
        Assert.AreEqual(1, defaultCube.GetLength());
        Assert.AreEqual(1, defaultCube.GetVolume());
        Assert.AreEqual(1, defaultCube.GetEdgeLength());
    }

    // Test a 2 x 4 x 2 Cube
    [Test]
    public void CubeTwoByFourByTwoTest()
    {
        // Setup and Act
        Cube twoByFourByTwo = new Cube(2f, 4f, 2f);

        // Assert
        Assert.AreEqual(2, twoByFourByTwo.GetHeight());
        Assert.AreEqual(4, twoByFourByTwo.GetWidth());
        Assert.AreEqual(2, twoByFourByTwo.GetLength());
        Assert.AreEqual(16, twoByFourByTwo.GetVolume());
        Assert.AreEqual(2, twoByFourByTwo.GetEdgeLength());
    }

    // Test a 10 x 10 x 10 Cube
    [Test]
    public void CubeTenByTenByTenTest()
    {
        // Setup and Act
        Cube tenByTenByTen = new Cube(10f, 10f, 10f);

        // Assert
        Assert.AreEqual(10, tenByTenByTen.GetHeight());
        Assert.AreEqual(10, tenByTenByTen.GetWidth());
        Assert.AreEqual(10, tenByTenByTen.GetLength());
        Assert.AreEqual(1000, tenByTenByTen.GetVolume());
        Assert.AreEqual(10, tenByTenByTen.GetEdgeLength());
    }

    
    [Test]
    public void CubeThreeByThreeByTwoTest()
    {
        // Setup and Act
        Cube threeByThreeByTwo = new Cube(3f, 3f, 2f);


        // Assert
        Assert.AreEqual(3, threeByThreeByTwo.GetHeight());  
        Assert.AreEqual(3, threeByThreeByTwo.GetWidth());
        Assert.AreEqual(2, threeByThreeByTwo.GetLength());
        Assert.AreEqual(18, threeByThreeByTwo.GetVolume());
        Assert.AreEqual(2, threeByThreeByTwo.GetEdgeLength());
    }
}
