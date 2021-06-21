import { useMutation } from "@apollo/client";
import { Button, Modal } from "@material-ui/core";
import { useState } from "react";
import WikiEntryForm from "./wiki-entry-form";

function WikiEntryButton() {
  const [open, toggleModal] = useState(false);
  const wikiEntry = <WikiEntryForm />;
  return (
    <div>
      <Button
        variant="contained"
        color="primary"
        onClick={() => toggleModal(true)}
      >
        Add
      </Button>
      <Modal
        open={open}
        onClose={() => toggleModal(false)}
        aria-labelledby="simple-modal-title"
        aria-describedby="simple-modal-description"
      >
        {wikiEntry}
      </Modal>
    </div>
  );
}

export default WikiEntryButton;
