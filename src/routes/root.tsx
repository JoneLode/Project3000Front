import React from "react";
import { Menu } from "../components/menu";
import { Outlet } from "react-router-dom";

export const Root: React.FC = () => {
  return (
    <div className="flex flex-col">
      <div>
        <Menu />
      </div>
      <div><Outlet /></div>
    </div>
  );
};
