import { makeStyles } from "@material-ui/core";
import Global from "./globals";

const SideBarStyles = makeStyles((theme) => ({
  drawer: {
    width: "100%",
    flexShrink: 0,
  },
  drawerPaper: {
    width: Global.drawerWidth,
  },
}));
export default SideBarStyles;
