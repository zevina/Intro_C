﻿// Просмотр папок и всего содержимого в них

void CatalogInfo(string path, string indent = "")
{
  DirectoryInfo catalog = new DirectoryInfo(path);

  DirectoryInfo[] catalogs = catalog.GetDirectories();
  for (int i = 0; i < catalogs.Length; i++)
  {
    Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + "  ");
  }

  FileInfo[] files = catalog.GetFiles();

  for (int i = 0; i < files.Length; i++)
  {
    Console.WriteLine($"{indent}{files[i].Name}");
  }
}


string path = @"E:\IT\VScode\3124_zevina";
CatalogInfo(path);