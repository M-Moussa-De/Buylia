import { Input } from "@nextui-org/react";

type Props = {
  variant?: "flat" | "bordered" | "faded" | "underlined";
  key?: string;
  label?: string;
  type?: string;
  fullWidth?: boolean;
  radius?: "none" | "sm" | "md" | "lg" | "full";
};

export default function CustomInput({
  variant = "flat",
  key,
  label,
  type = "text",
  fullWidth = true,
  radius = "sm",
}: Props) {
  return (
    <Input
      variant={variant}
      key={key}
      label={label}
      type={type}
      fullWidth={fullWidth}
      radius={radius}
    />
  );
}
